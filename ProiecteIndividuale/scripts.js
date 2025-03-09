// DATE & TIME PROCESSOR
function displayDateTime() {
    const now = new Date();
    const dateTimeDisplay = document.getElementById('date-time-display');
    dateTimeDisplay.textContent = "Current Local Time: " + now.toLocaleString();
  
    // Timezone Conversion
    const timezoneSelect = document.getElementById('timezone');
    const offset = parseInt(timezoneSelect.value);
    // Convert current time to UTC, then adjust by the offset (simple conversion)
    const utcTime = now.getTime() + (now.getTimezoneOffset() * 60000);
    const convertedTime = new Date(utcTime + (3600000 * offset));
    const convertedDisplay = document.getElementById('converted-time');
    convertedDisplay.textContent = "Time at UTC" + (offset >= 0 ? '+' : '') + offset + ": " + convertedTime.toLocaleString();
  }
  
  setInterval(displayDateTime, 1000);
  displayDateTime();
  
  document.getElementById('timezone').addEventListener('change', displayDateTime);
  
  document.addEventListener('DOMContentLoaded', function() {
    let slideIndex = 0;
    let slides = document.getElementsByClassName('slide');
    let slideTimer;
  
    function showSlide(index) {
      // Wrap around if index is out of bounds
      if (index >= slides.length) { slideIndex = 0; }
      if (index < 0) { slideIndex = slides.length - 1; }
      // Hide all slides
      for (let i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
      }
      slides[slideIndex].style.display = "block";
    }
  
    function nextSlide() {
      slideIndex++;
      showSlide(slideIndex);
      resetSlideTimer();
    }
  
    function prevSlide() {
      slideIndex--;
      showSlide(slideIndex);
      resetSlideTimer();
    }
  
    function startSlideShow() {
      showSlide(slideIndex);
      slideTimer = setInterval(function() {
        slideIndex++;
        showSlide(slideIndex);
      }, 3000); // Change slide every 3 seconds
    }
  
    function resetSlideTimer() {
      clearInterval(slideTimer);
      slideTimer = setInterval(function() {
        slideIndex++;
        showSlide(slideIndex);
      }, 3000);
    }
  
    // Attach event listeners to navigation arrows
    document.querySelector('.next').addEventListener('click', nextSlide);
    document.querySelector('.prev').addEventListener('click', prevSlide);
  
    // Start the slideshow
    startSlideShow();
  });
  
  // DYNAMIC FORM VALIDATION
  
  const form = document.getElementById('contact-form');
  
  // Helper function for validating fields
  function validateField(field, errorElementId, validationFunc, errorMessage) {
    const value = field.value.trim();
    if (!validationFunc(value)) {
      document.getElementById(errorElementId).textContent = errorMessage;
      return false;
    } else {
      document.getElementById(errorElementId).textContent = "";
      return true;
    }
  }
  
  // Real-time validation for each field
  document.getElementById('name').addEventListener('input', function() {
    validateField(this, 'name-error', val => val !== "", "Name is required.");
  });
  
  document.getElementById('email').addEventListener('input', function() {
    validateField(this, 'email-error', val => /^\S+@\S+\.\S+$/.test(val), "Please enter a valid email.");
  });
  
  document.getElementById('message').addEventListener('input', function() {
    validateField(this, 'message-error', val => val !== "", "Message is required.");
  });
  
  form.addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent default form submission
    let valid = true;
    
    valid = validateField(document.getElementById('name'), 'name-error', val => val !== "", "Name is required.") && valid;
    valid = validateField(document.getElementById('email'), 'email-error', val => /^\S+@\S+\.\S+$/.test(val), "Please enter a valid email.") && valid;
    valid = validateField(document.getElementById('message'), 'message-error', val => val !== "", "Message is required.") && valid;
    
    if (valid) {
      alert("Form submitted successfully!");
      form.reset();
    }
  });
  